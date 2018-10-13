using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Business.Concrete
{
    class ValidationEntries
    {
        public void characterValidatorOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace e nem vírgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9 e vírgula");
                }
            }
        }

        public void characterValidatorOnlyPhones(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace e nem traço e nem parenteses
            // 08 backspace, 45 traço, 40 e 41 parenteses, 32 espaco
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 45 && e.KeyChar != 40 && e.KeyChar != 41 && e.KeyChar != 32)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9 e vírgula");
                }
            }
        }

        public void characterValidatorOnlyCPFandCNPJ(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace e nem ponto, nem barra diagonal e nem traço
            // 08 backspace, 46 ponto, 47 barra diagonal, 45 traço
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46 && e.KeyChar != 47 && e.KeyChar != 45)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9 e vírgula");
                }
            }
        }

        public void characterValidatorOnlyCEP(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace e nem traço
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 45)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9 e vírgula");
                }
            }
        }

        public void characterValidatorOnlyTime(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace e nem dois pontos
            // 08 backspace, 58 dois pontos
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 58)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9 e vírgula");
                }
            }
        }
    }
}
