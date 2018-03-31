using System;
using System.Collections.Generic;
using System.Linq;

namespace DigiAeon.ParcelDelivery.Domain
{
    public class BrokenRulesException<TEntity> : Exception
        where TEntity : IReadOnlyEntity
    {
        public BrokenRulesException(List<string> brokenRules)
        {
            var brokenRulesDescription = string.Join(", ", brokenRules.Select(x => string.Format("{0}{1}", x, "\n")));

            throw new Exception(string.Format("Entity is not valid. ({0}) \n Error(s): \n {1})", typeof(TEntity), brokenRulesDescription));
        }
    }
}
