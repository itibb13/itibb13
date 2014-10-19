using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIBB
{
    /// <summary>
    /// Print information about the exercise
    /// </summary>
    public class ExerciseInfo
    {
        /// <summary>
        /// 
        /// </summary>
        private ExerciseInfo()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exercise">name of the exercise</param>
        /// <param name="author">the name of the author/student</param>
        public static void Print(string exercise, string author)
        {
            Print(exercise, author, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exercise">name of the exercise</param>
        /// <param name="author">name of the author/student</param>
        /// <param name="id">id of the author</param>
        public static void Print(string exercise, string author, string id)
        {
            Console.WriteLine("################################");
            Console.WriteLine("Exercise  : " + exercise);
            Console.WriteLine("Author    : " + author);
            if (id != null)
                Console.WriteLine("MatrikelNr: " + id);
            Console.WriteLine("################################\n");
        }
    } // end class ExerciseInfo

} // end namespace
