   public static string gridSearch(List<string> G, List<string> P)
        {
            var startWord = P[0];

            var candidates = new Queue<(int Row, int Start, int End)>();


            for (int i = 0; G.Count - i >= P.Count; i++)
            {
                var row = G[i];
                int searchStartIndex = 0;
                while (searchStartIndex < row.Length)
                {
                    var start = row.IndexOf(startWord, searchStartIndex);
                    if (start >= 0)
                    {
                        candidates.Enqueue((i, start, startWord.Length));
                        searchStartIndex += 1;
                    }
                    else
                    {
                        break;
                    }
                }

            }

            if (candidates.Count == 0) return "NO";



            while (candidates.Count > 0)
            {
                var currCandidate = candidates.Dequeue();

                var match = true;
                for (int i = currCandidate.Row + 1, j = 1; match && j < P.Count; i++, j++)
                {
                    var next = G[i].Substring(currCandidate.Start, currCandidate.End);
                    if (next != P[j]) match = false;
                }

                if (match) return "YES";
            }

            return "NO";
        }
