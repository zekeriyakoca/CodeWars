// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;
using System.Text;
using CodeWars;
using CodeWars.Solutions;

var result = NonRepeatingCharacter.FirstNonRepeatingLetter("rrr");
Console.WriteLine(String.Join('-', result));