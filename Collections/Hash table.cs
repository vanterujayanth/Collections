using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Hash_Table
    {
        public Hash_Table()
        {
            Console.WriteLine("hash table demo :");
            Hashtable ht = new Hashtable();
            ht.Add("e_name", "jayanth");
            ht.Add("e_id", 101);
            ht.Add("Phone", "9390908957");
            ht.Add("Address", "kavali");
            ht.Add("pin_code", "524241");
            ht.Add("location", "nellore");
            ht.Add("job", "ff");
            ht.Add("department", "development");
            ht.Add("email", "vanterujayanth2001@gmail.com");
            foreach (var item in ht)
                Console.WriteLine(item + " ");
            Console.WriteLine(ht["email"]);
        }
    }
}
