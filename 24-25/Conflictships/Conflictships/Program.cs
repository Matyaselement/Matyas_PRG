using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflictships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*V kódu používám chatGPT ve velké míře, protože často prostě vůbec nevím jak na to.
            Nechat si to vysvětlit od chatGPT je nejrychlejší a nejjednodušší pro mne,
            a zároveň se snažím co nejméně kód kopírovat a když už se k tomu uchýlím,
            snažím se pořád tomu co kopíruju alespoň co nejlépe porozumět.
            Tohle tu píšu primárně kvůli tomu, že kdybych musel označit každou část kde chatGPT použiju,
            bylo by toho až moc a snažím se to psát spíše tam, kde ho požívám více.*/

            Sea mojePole = new Sea();
            mojePole.Render();
            Console.ReadKey();
        }
    }
}
