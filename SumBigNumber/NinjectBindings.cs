using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumberStrategy
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {


            //Bind<SumStrategy>().To<BigSumStrategy>().Named("Sum");
            //Bind<SumStrategy>().To<ParallelBigSumStrategy>().Named("SumParallel");

            //Bind<MultipleStrategy>().To<BigMultipleStrategy>().Named("Multiple");
            //Bind<MultipleStrategy>().To<ParallelBigMultipleStrategy>().Named("ParallelMultiple");

            Bind<SumStrategy>().To<BigSumStrategy>();
            Bind<MultipleStrategy>().To<BigMultipleStrategy>();

        }
    }
}
