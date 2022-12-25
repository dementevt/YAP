using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			GetDecryption("êōōĦÉōĬįŖuř`�`ೃಐ಴ೡಟ`ಱ೉ೕ೘ನಟc");
			GetDecryption("౩`ಜ೭ಜನ`శಐೃನ`ೃಱ಺಴ಐಱೃ೭`ಮಐಱ೤ಮ೉ಱ೭ೆ಺ೀc");
			GetDecryption("ౝೀಟಜ೉ಽೀಟಜನೆಟ`ಟಙ಺�`ಽ಺ಮಐ`಺ಷ`ಷಟ`೉೘ಟಱ`ಷಐ`ೃಮಱಐಜc");
			GetDecryption("ౚೆಖಟೆ`ಷಐ`ೃಟಮೀಟೆಷೡಫ`ಖ಺ಽೀ಺ೃ®`ౣ಺ಮೀಐ೛ಟಷಷಐ೭`ಥಐಽನೃ೤`಴ಟೆ಺ಜ಺ಖ");
			GetDecryption("఼ಱ೭`ಽ಺ಱ೉ೕಟಷನ೭`ಓಐಱಱ಺ಖ`೉ಜಐಱನೆಟ`ೆಟಱ಺`಴ಟೆ಺ಜಐ`ನ`಺ೆಽೀಐಖ೤ೆಟ");
		}
		
		static void GetDecryption(string importantMessage){
			char[] message = importantMessage.ToCharArray();
			for(int i = 0; i < message.Length; i++)
			{
				message[i] = Convert.ToChar(message[i]/3);
				Console.Write(message[i]);
			}
			Console.WriteLine();
		}
	}
}