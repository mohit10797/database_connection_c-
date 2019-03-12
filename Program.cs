using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using function;

class Program
{
    static void Main(string[] args)
    {
        numeric_functions nf = new numeric_functions();
        string_functions sf = new string_functions();
        double[] input = new Double[10];
        double d_input = 0, e_input = 0, f_input = 0;
        string str_input;
        void one_input_numeric()
        {
            Console.WriteLine("Enter the number");
            try
            {
                f_input = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        void two_input_numeric()
        {
            Console.WriteLine("Enter two numbers");
            try
            {
                d_input = Convert.ToDouble(Console.ReadLine());
                e_input = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        void get_range()
        {
            Console.WriteLine("Enter the length of numbers you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numbers");
            try
            {
                for (int i = 0; i < n; i++)
                {
                    input[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        string get_string()
        {
            Console.WriteLine("Enter string");
            return Console.ReadLine();
        }
        Console.WriteLine("1. Add \n 2. subtract \n 3. Multiply \n 4. Divide \n 5. Find max \n 6. Find Min \n 7. Check no. for Even \n 8. Check number for odd \n 9. Check number for prime \n 10. Display All even even numbers in a given range \n 11. Display all odd numbers in a given range. \n 12. Display all prime numbers in a given range \n 13. Display table of the number \n 14. Display table in of the range. \n 15. Display table within range \n 16. Reverse a number \n 17. Find number of characters in a string \n 18. Check string for palindrome \n 19. Reverse a sentence \n 20. Find no. of vowels, consonats and special characters in a string. \n 21. Change case to upper case \n 22. Change case to proper case. \n 23. Combine two sentences. \n 24. Remove extra spaces in a sentence \n 25. Count no. of words in a sentence \n 26. Search a substring /n 27. Find the number of occurences of a substring in a sentence. \n Enter your choice");
        Byte x = Convert.ToByte(Console.ReadLine());
        try
        {
            switch (x)
            {

                case 1:
                    get_range();
                    Console.WriteLine(nf.addnumber(input));
                    break;
                case 2:
                    two_input_numeric();
                    Console.WriteLine(nf.subnumber(d_input, e_input));
                    break;
                case 3:
                    two_input_numeric();
                    Console.WriteLine(nf.multinumber(d_input, e_input));
                    break;
                case 4:
                    two_input_numeric();
                    try
                    {
                        Console.WriteLine(nf.divnumber(d_input, e_input));
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    break;
                case 7:
                    one_input_numeric();
                    Console.WriteLine(nf.evenbumber(Convert.ToInt32(f_input)));
                    break;
                case 8:
                    one_input_numeric();
                    Console.WriteLine(nf.oddbumber(Convert.ToInt32(f_input)));
                    break;
                case 9:
                    one_input_numeric();
                    Console.WriteLine(nf.isprime(Convert.ToInt32(f_input)));
                    break;
                case 10:
                    two_input_numeric();
                    nf.EvenRange(Convert.ToInt32(d_input), Convert.ToInt32(e_input));
                    break;
                case 11:
                    two_input_numeric();
                    nf.OddRange(Convert.ToInt32(d_input), Convert.ToInt32(e_input));
                    break;
                case 12:
                    two_input_numeric();
                    nf.PrimeRange(Convert.ToInt32(d_input), Convert.ToInt32(e_input));
                    break;
                case 13:
                    one_input_numeric();
                    Console.WriteLine(nf.tabledisplay(Convert.ToInt16(f_input)));
                    break;
                case 14:
                    two_input_numeric();
                    Console.WriteLine(nf.TableInRange(Convert.ToInt32(d_input), Convert.ToInt32(e_input)));
                    break;
                case 15:
                    two_input_numeric();
                    Console.WriteLine("Enter range for tables");
                    int r_input = Convert.ToInt32(Console.ReadLine());
                    int s_input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(nf.TableWithInRange(Convert.ToInt32(d_input), Convert.ToInt32(e_input), r_input, s_input));
                    break;
                case 16:
                    one_input_numeric();
                    Console.WriteLine(nf.ReverseNumber(Convert.ToInt32(f_input)));
                    break;
                case 17:
                    str_input = get_string();
                    Console.WriteLine(sf.count_characters(str_input));
                    break;
                case 18:
                    str_input = get_string();
                    Console.WriteLine(sf.check_pallindrome(str_input));
                    break;
                case 19:
                    str_input = get_string();
                    Console.WriteLine(sf.reverse_sentence(str_input));
                    break;
                case 20:
                    str_input = get_string();
                    sf.count_occurence(str_input);
                    break;
                case 21:
                    str_input = get_string();
                    Console.WriteLine(sf.toupper(str_input));
                    break;
                //case 22:
                //    str_input = get_string();
                //    Console.WriteLine(sf)
                //    break;
                case 23:
                    str_input = get_string();
                    string tr_input2 = get_string();
                    Console.WriteLine(sf.combine_senetce(str_input, tr_input2));
                    break;
                case 24:
                    str_input = get_string();
                    Console.WriteLine(sf.remove_extra_spaces(str_input));
                    break;
                case 25:
                    str_input = get_string();
                    Console.WriteLine(sf.count_words(str_input));
                    break;
                case 26:
                    str_input = get_string();
                    string str_input2 = get_string();
                    Console.WriteLine(sf.search_substring(str_input, str_input2));
                    break;
                case 27:
                    str_input = get_string();
                    str_input2 = get_string();
                    Console.WriteLine(sf.substring_occurence(str_input, str_input2));
                    break;
            }
        }
        catch (Exception e) { Console.WriteLine(e.Message); }


    }
}

