using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test;

public class TrieNode
{
    public static int Alphabet_Size = 26;
    public TrieNode[] children = new TrieNode[Alphabet_Size];
    public static TrieNode root;
    public bool IsEndOfWord;
    public TrieNode()
    {

        IsEndOfWord = false;
        for (int i = 0; i < children.Length; i++)
        {
            children[i] = null;
        }
    }
    public static bool Insert(string value)
    {


        TrieNode pointer = root;

        for (int i = 0; i < value.Length; i++)
        {
            int index = value[i] - 'a';

            if (pointer.children[index] == null)
            {
                pointer.children[index] = new TrieNode();
            }
            pointer = pointer.children[index];


        }
        pointer.IsEndOfWord = true;

        return pointer.IsEndOfWord;



    }

    public static bool search(string value)
    {

        TrieNode pointer = root;

        for (int i = 0; i < value.Length; i++)
        {
            int index = value[i] - 'a';

            if (pointer.children[index] == null)
            {
                return false;
            }
            pointer = pointer.children[index];


        }
        return pointer.IsEndOfWord;





    }


    public static bool InsertArray(string[] strs)
    {
        foreach (var itme in strs)
        {


            if (!TrieNode.Insert(itme))
            {

                return false;
            }
        }


        return true;

    }

    public static string LongestCommonPrefix(string[] strs)
    {
        string pattern = "";
        string prefix = "";

        if (strs.Length == 1)
        {

            return strs[0];


        }
        if (InsertArray(strs))
        {
           
            for (int i = 1; i < strs.Length; i++)
            {
                pattern = strs[i-1];
                TrieNode pointer = root;
                if (strs[i] == "")
                {

                    return "";

                }
              
                for (int j = 0; j < strs[i].Length; j++)
                {
                    int index = strs[i][j] - 'a';
                    



                    if (pointer.children[index] != null)
                    {
                        if (pattern.StartsWith(strs[i][j])|| pattern.StartsWith(prefix))
                        {
                            prefix += strs[i][j];


                        }
                        else {

                            break;
                        
                        
                        }
                    }



        



                    pointer = pointer.children[index];



                }




            }
          

        }
        return prefix;





    }

}
