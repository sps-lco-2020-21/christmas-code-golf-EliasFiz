using System;

namespace a
{
    class b
    {
        static void Main()
        {
            string[] x = new string[24] {"first","second","third","fourth","fifth","sixth","seventh","eighth","ninth","tenth","eleventh","twelfth","A partridge in a pear tree","Two turtle doves","Three french hens","Four calling birds","Five golden rings","Six geese a-laying","Seven swans a-swimming","Eight maids a-milking","Nine ladies dancing","Ten lords a-leaping","Eleven pipers piping","Twelve drummers drumming"};

            for (int i = 0; i < 12; ++i)
            {

                Console.WriteLine("On the " + x[i] + " day of Christmas, my true love gave to me");

                int j = i + 13;
                while (j-- > 12)
                    Console.WriteLine(x[j]);

                Console.WriteLine();

                if (i == 0)
                    x[12] = "And a partridge in a pear tree";
            }
        }
    }
}


