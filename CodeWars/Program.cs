// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;
using System.Text;
using CodeWars;
using CodeWars.Solutions;

var matrix = new int[][]
{
    new int[] {1,2,3,9 },
    new int[] { 4,5,6,4},
    new int[] {7,8,9,1 },
    new int[] {1,2,3,4}
};
var result = SnailSolution.Snail(matrix);
Console.Write("");
