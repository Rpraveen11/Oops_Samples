using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Oops_Concepts
    {
        internal interface Animal
        {
            void cat();
            void bird();
            void fish();
        }
        class Nature : Animal  // here implenets the interface

        {
            //here i implemnts methods from the interface abstract method into derived class non abstract methodd
            public void cat()
            {
                Console.WriteLine("Cat can Walk");
            }
            public void bird()
            {
                Console.WriteLine("Bird can Fly");

            }
            public void fish()
            {
                Console.WriteLine("Fish can Swim");

            }

            public static void main(String[] args)
            {
                Nature n = new Nature();
                n.fish();
                n.bird();
                n.cat();
            }
        }
    }

}
