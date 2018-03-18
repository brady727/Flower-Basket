﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//////////////////////////////////////////////////
//                                              //
//  Word_Search                                 //
//  by Brady Smith                              //
//                                              //
//////////////////////////////////////////////////

namespace Florae_Basket
{
    class Word_Search
    {
        //contains the string of the candidate, as well as the database key
        //and the score calculated from the LCS method.
        public struct Candidate
        {
            public string contents;
            public int id;
            public double score;
        };

        private int[] results = new int[3];                   //array containing the database id of the 3 best results.
        private Candidate[] best_names = new Candidate[3];    //arrays containging the 3 best candidates for every entry.
        private Candidate[] best_latin = new Candidate[3];
        private Candidate[] best_botan = new Candidate[3];
        private string name;
        private string latin;
        private string botan;
        private LinkedList<Candidate> possible_names;         //Linked list containing the Candidates pulled from the database.

        public Word_Search(string enl_name, string latin_name, string botan_name)
        {
            name = enl_name;
            latin = latin_name;
            botan = botan_name;
        }

        public string Get_name()
        {
            return name;
        }

        public string Get_latin()
        {
            return latin;
        }

        public string Get_botan()
        {
            return botan;
        }

        public int[] Get_results()
        {
            return results;
        }

        //Longest Common SubString
        //Calculates the match score for two strings.
        //This score represents the number of characters each string has in common.
        private int LCS(string entry, string cand, int x, int y)
        {
            //base case
            if (x == 0 || y == 0)
            {
                return 0;
            }
            //when a letter matches add one to score
            else if (entry[x] == cand[y])
            {
                return Math.Max(1 + LCS(entry, cand, x - 1, y - 1), Math.Max(LCS(entry, cand, x - 1, y), LCS(entry, cand, x, y - 1)));
            }
            //when letter does not match evaluate 
            else
            {
                return Math.Max(LCS(entry, cand, x - 1, y), LCS(entry, cand, x, y - 1));
            }
        }

        //Fetch english names from the Database using just first letter of the search entry
        //Stores results into linked list that is passed by reference
        private void Fetch_names(string name, ref LinkedList<Candidate> list)
        {
            try
            {
                //TODO
                //Query the database using ***ONLY THE FIRST LETTER*** of the entered word
                //The database will return every entry it holds that begins with that letter
                //The database will only return candidates from that column.
            }
            catch (Exception)
            {

                throw;
            }
        }

        //executes the word search and populates the results array
        public void Search()
        {
            Candidate temp;
            possible_names.Clear();
            //Makes sure name has a value
            if (name != null && name != "")
            {
                Fetch_names(name, ref possible_names);
                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs LCS on current candidate
                    temp.score = LCS(name, temp.contents, name.Length, temp.contents.Length);
                    //Compares score with current best score
                    if (temp.score > best_names[0].score)
                    {
                        best_names[2] = best_names[1];
                        best_names[1] = best_names[0];
                        best_names[0] = temp;
                    }
                    //compares with second highest
                    else if (temp.score > best_names[1].score)
                    {
                        best_names[2] = best_names[1];
                        best_names[1] = temp;
                    }
                    //compares with third highest
                    else if (temp.score > best_names[2].score)
                    {
                        best_names[2] = temp;
                    }
                    //reseting temp value
                    temp.score = 0.0;
                    temp.id = 0;
                    temp.contents = "";
                }
            }
            //clearing list for next word to be run
            possible_names.Clear();
            if (latin != null && latin != "")
            {
                Fetch_names(latin, ref possible_names);
                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs LCS on current candidate
                    temp.score = LCS(latin, temp.contents, latin.Length, temp.contents.Length);
                    //Compares score with current best score
                    if (temp.score > best_latin[0].score)
                    {
                        best_latin[2] = best_latin[1];
                        best_latin[1] = best_latin[0];
                        best_latin[0] = temp;
                    }
                    //compares with second highest
                    else if (temp.score > best_latin[1].score)
                    {
                        best_latin[2] = best_latin[1];
                        best_latin[1] = temp;
                    }
                    //compares with third highest
                    else if (temp.score > best_latin[2].score)
                    {
                        best_latin[2] = temp;
                    }
                    //reseting temp value
                    temp.score = 0.0;
                    temp.id = 0;
                    temp.contents = "";
                }
            }
            //clearing list for next word to be run
            possible_names.Clear();
            if (botan != null && botan != "")
            {
                Fetch_names(botan, ref possible_names);
                //Loops through pulled list
                for (int i = 0; i < possible_names.Count; i++)
                {
                    //stores current candidate into for testing
                    temp = possible_names.ElementAt(i);
                    //runs LCS on current candidate
                    temp.score = LCS(botan, temp.contents, botan.Length, temp.contents.Length);
                    //Compares score with current best score
                    if (temp.score > best_botan[0].score)
                    {
                        best_botan[2] = best_botan[1];
                        best_botan[1] = best_botan[0];
                        best_botan[0] = temp;
                    }
                    //compares with second highest
                    else if (temp.score > best_botan[1].score)
                    {
                        best_botan[2] = best_botan[1];
                        best_botan[1] = temp;
                    }
                    //compares with third highest
                    else if (temp.score > best_botan[2].score)
                    {
                        best_botan[2] = temp;
                    }
                    //reseting temp value
                    temp.score = 0.0;
                    temp.id = 0;
                    temp.contents = "";
                }
            }
        }
    }
}
