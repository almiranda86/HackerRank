using System;
using System.Collections.Generic;
using System.Linq;

namespace ChooseAFlask
{
    public static class Result
    {
        static Dictionary<int, List<int>> _markings;
        public static int chooseFlask(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {
            int response = -1;

            if (requirements.Count == 0)
                return response;

            if (flaskTypes == 0)
                return response;

            if (markings.Count == 0)
                return response;

            Dictionary<int, int> minWaste = new Dictionary<int, int>();
            _markings = new Dictionary<int, List<int>>();
            
            foreach (var mark in markings)
            { DoSomeOrganization(mark); }

            int x = 0;

            foreach (var markingLine in _markings)
            {
                var line = markingLine.Key;
                var markValue = markingLine.Value;


                var lineValues = markValue.Where(value => requirements.Any(requirementValue => requirementValue <= value) &&
                                                            !requirements.Any(requirementValue => requirementValue > value)).ToList();


                if (lineValues.Count > 0)
                {
                    if (!minWaste.ContainsKey(line))
                    {
                        minWaste.Add(line, 0);
                        x = 0;
                    }

                    for (int i = 0; i < markValue.Count; i++)
                    {
                        for (; x < requirements.Count;)
                        {
                            if (requirements[x] <= markValue[i])
                            {
                                minWaste[line] += markValue[i] - requirements[x];
                                x++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            if (minWaste.Count > 0)
                response = minWaste.OrderBy(x => x.Value).FirstOrDefault().Key;

            return response;
        }

        static void DoSomeOrganization(List<int> mark)
        {
            var l = mark.ElementAt(0);

            var m = mark.ElementAt(1);

            if (!_markings.ContainsKey(l))
            {
                _markings.Add(l, new List<int>() { m });
            }
            else
            {
                _markings[l].Add(m);
            }
        }
    }
}
