using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Entities.Enum;

namespace UIWindows.Business.Concrete
{
    public class ValidationEntries
    {
        MessageBoxTimer msg = new MessageBoxTimer();

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

        public void characterValidatorNumbers(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9");
                }
            }
        }

        public void characterValidatorLetters(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada for letras
            if (char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9");
                }
            }
        }

        public void characterValidatorNumbersCheque(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada nao for numeros espaço ou traço
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 08)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9");
                }
            }
        }


        public void characterValidationOnlyNumberAndLetters(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número ou letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar >= 65 && e.KeyChar <= 90)
            {
                e.Handled = true;
                if (e.Handled)
                {
                    //MessageBox.Show("incluir apenas números de 0 a 9 e letras de A a Z");
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

        public bool returnCampsEmpty(TextBox e, string txt)
        {
            if (e.Text.Length.Equals(0))
            {
                msg.Show("Campo Vazio", "O Campo Obrigatório '" + txt + "' está vazio.", 0, 2000);
                e.Focus();
                return false;
            }

            return true;
        }

        public Estate estate(int num)
        {
            switch (num)
            {
                case 0: return Estate.AC;
                case 1: return Estate.AL;
                case 2: return Estate.AP;
                case 3: return Estate.AM;
                case 4: return Estate.BA;
                case 5: return Estate.CE;
                case 6: return Estate.DF;
                case 7: return Estate.ES;
                case 8: return Estate.GO;
                case 9: return Estate.MA;
                case 10: return Estate.MT;
                case 11: return Estate.MS;
                case 12: return Estate.MG;
                case 13: return Estate.PA;
                case 14: return Estate.PB;
                case 15: return Estate.PR;
                case 16: return Estate.PE;
                case 17: return Estate.PI;
                case 18: return Estate.RJ;
                case 19: return Estate.RN;
                case 20: return Estate.RS;
                case 21: return Estate.RO;
                case 22: return Estate.RR;
                case 23: return Estate.SC;
                case 24: return Estate.SP;
                case 25: return Estate.SE;
                case 26: return Estate.TO;
            }

            return 0;
        }

        public int estatePerString(string estate)
        {
            switch (estate)
            {
                case "AC": return 0;
                case "AL": return 1;
                case "AP": return 2;
                case "AM": return 3;
                case "BA": return 4;
                case "CE": return 5;
                case "DF": return 6;
                case "ES": return 7;
                case "GO": return 8;
                case "MA": return 9;
                case "MT": return 10;
                case "MS": return 11;
                case "MG": return 12;
                case "PA": return 13;
                case "PB": return 14;
                case "PR": return 15;
                case "PE": return 16;
                case "PI": return 17;
                case "RJ": return 18;
                case "RN": return 19;
                case "RS": return 20;
                case "RO": return 21;
                case "RR": return 22;
                case "SC": return 23;
                case "SP": return 24;
                case "SE": return 25;
                case "TO": return 26;
            }

            return 0;
        }
    }
}
