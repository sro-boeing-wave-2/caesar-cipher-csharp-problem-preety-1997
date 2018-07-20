using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
		public static string Rotate(string text, int shiftKey)
		{
			string Ciphertext = "";
			for (int i = 0; i < text.Length; i++)
			{
				if (((int)text[i] >=(int)'a' && (int)text[i] <= (int)'z'))
				{
					int sum = (int)text[i] + shiftKey;
					if (sum >= 123)
					{
						Ciphertext += (char)('a'+(sum-123));
					}
					
					else     
					{
						Ciphertext += (char)(text[i] + shiftKey);
					}
				}
				else if (((int)text[i] >= 65 && (int)text[i] <= 90))
				{
					int sum = (int)text[i] + shiftKey;
					if (sum >= 91)
					{
						Ciphertext += (char)('A' +(sum -91));
					}
					
					else
					{
						Ciphertext += (char)(text[i] + shiftKey);
					}
				}
				else {
					Ciphertext += text[i];
				}
			}
			return Ciphertext;

		}
	}
}
