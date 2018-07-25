using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
	public static class RotationalCipher
	{
		public static string Rotate(string text, int shiftKey)
		{
			StringBuilder output = new StringBuilder();

			foreach (char replace in text)
				output.Append(rotate(replace, shiftKey));

			return output.ToString();
		}
		public static char rotate(char replace, int shiftKey)
		{
			if (!char.IsLetter(replace))
			{

				return replace;
			}
			char upperOrlower = char.IsUpper(replace) ? 'A' : 'a';
			return (char)((((replace + shiftKey) - upperOrlower) % 26) + upperOrlower);


		}
	}
}