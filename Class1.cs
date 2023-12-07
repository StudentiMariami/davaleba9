using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba9
{
 /*   
შექმენით ინტერფეისი, რომელიც ორ მეთოდს შეიცავს.I მეთოდი გამოთვლის და
აბრუნებს პარამეტრის კვადრატს, II კი - პარამეტრის კუბს.მოახდინეთ ამ ინტერფეისის
რეალიზება.*/
    public interface interfeisi_1
    {
        int param_kvad(int par1);
        int param_kubi(int par1);
    }

    class Class1:interfeisi_1
    {
        public int param_kvad(int par1) {  return par1*par1; }
        public int param_kubi(int par1) { return par1*par1*par1;}
    }
}
