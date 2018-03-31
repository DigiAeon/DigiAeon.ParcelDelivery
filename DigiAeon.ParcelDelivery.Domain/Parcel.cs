using System.Collections.Generic;
using System.Linq;

namespace DigiAeon.ParcelDelivery.Domain
{
    public class Parcel : ReadOnlyEntityBase<Parcel>, IReadOnlyEntity
    {
        public Parcel(int weight, int height, int width, int depth)
        {
            Weight = weight;
            Height = height;
            Width = width;
            Depth = depth;

            var errors = Validate(this);

            if (errors.Any())
            {
                ThrowInvalidEntityException(errors);
            }
        }

        public int Weight { get; private set; }

        public int Height { get; private set; }

        public int Width { get; private set; }

        public int Depth { get; private set; }

        public long Volume
        {
            get
            {
                return Height * Width * Depth;
            }
        }

        protected override List<string> Validate(Parcel entity)
        {
            var errors = new List<string>();

            if (entity.Weight <= 0)
            {
                errors.Add("Weight cannot be zero or less");
            }

            if (entity.Height <= 0)
            {
                errors.Add("Height cannot be zero or less");
            }

            if (entity.Width <= 0)
            {
                errors.Add("Width cannot be zero or less");
            }

            if (entity.Depth <= 0)
            {
                errors.Add("Depth cannot be zero or less");
            }

            return errors;
        }
    }
}
