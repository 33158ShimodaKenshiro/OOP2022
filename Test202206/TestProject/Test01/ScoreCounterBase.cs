namespace Test01 {
    internal class ScoreCounterBase {




        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> sales = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student sale = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                sales.Add(sale);








            }

            //メソッドの概要： 
            IDictionary<string, int> GetPerStudentScore() {
                var dict = new Dictionary<string, int>();
                foreach (var score in _score) {
                    if (dict.ContainsKey(score.Name))
                        dict[score.Name] += score.Score;
                    else
                        dict[score.Name] = score.Score;
                }
                return dict;






            }
        }
    }
}