/* Author : Michael Jespersen
 * Date : 1 october 2013
 * Time : 18:28
 */

using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace variance{
  public class Test{

    // if predicate p holds for all elements in the array
    private static bool Forall(int[] xs, Func<int,bool> p){
      foreach(int i in xs)
        if ( !p( i ) ) return false;

      return true;
    }

    private static bool Forall<T>(IEnumerable<T> xs, Func<T, bool> p){
       foreach(T i in xs)
        if ( !p( i ) ) return false;

      return true;
    }

    // if predicate p holds for at least one element in the array
    private static bool Exists(int[] xs, Func<int,bool> p){
      foreach(int i in xs)
        if ( p( i ) ) return true;

      return false;
    }

    private static bool Exists<T>(IEnumerable<T> xs, Func<T,bool> p){
      foreach(T i in xs)
        if ( p( i ) ) return true;

      return false;
    }

    private static List<int> Merge(List<int> a, List<int> b){
      List<int> r = new List<int>();
      
      var posA = 0;
      var posB = 0;

      int[] arrA = a.ToArray();
      int[] arrB = b.ToArray();

      for ( int i = 0; i < (arrA.Length + arrB.Length); i++ ){
        if ( posA > arrA.Length - 1) r.Add( arrB[posB++] );
        else if (posB > arrB.Length - 1 ) r.Add( arrA[posA++] );
        else if (arrA[posA].CompareTo(arrB[posB]) < 0) r.Add(arrA[posA++]);
        else r.Add(arrB[posB++]);
      }

      return r;
    }

    private static List<T> Merge<T>(List<T> a, List<T> b) where T : IComparable<T>{
      List<T> r = new List<T>();

      var posA = 0;
      var posB = 0;

      T[] arrA = a.ToArray();
      T[] arrB = b.ToArray();

      for ( int i = 0; i < (arrA.Length + arrB.Length); i++ ){
        if ( posA > arrA.Length - 1) r.Add( arrB[posB++] );
        else if (posB > arrB.Length - 1 ) r.Add( arrA[posA++] );
        else if (arrA[posA].CompareTo(arrB[posB]) < 0) r.Add(arrA[posA++]);
        else r.Add(arrB[posB++]);
      }

      return r;
    }



    public static void Main(String[] args){
      int[] arr= {2, 4}; 

      Func<int, bool> even = x => x%2 == 0;
      Debug.Assert( Forall( arr, even ));
      Debug.Assert( Forall( arr, even ));

      // ex2
      int[][] jaggedArray = new int[][] {
        new int[] {1, 2, 4},
        new int[] {1, 2, 3}
      };
      Func<int[], bool> len = x => x.Length > 2;

      Debug.Assert( Forall( jaggedArray, len ));
      Debug.Assert( Exists( jaggedArray, len ));

      // ex3
      List<int> xl = new List<int>( 
        new int[] {0,2,4} 
      );
      List<int> yl = new List<int>(
        new int[] {1,3}
      );

      List<int> ml = Merge(xl, yl);

      for(int i = 0; i < ml.Count; i++){
        System.Console.Write(ml[i]);
        if( !(i==ml.Count-1) )
          System.Console.Write(", ");
      }
      System.Console.WriteLine();

      // ex4
      List<string> xls = new List<string>(
        new String[] {"a", "c", "e"}
      );

      List<string> yls = new List<string>(
        new String[] {"b", "d"}
      );

      List<String> mls = Merge<String>(xls, yls);
      for(int i = 0; i < mls.Count; i++){
        System.Console.Write(mls[i]);
        if( !(i==mls.Count-1) )
          System.Console.Write(", ");
      }
      System.Console.WriteLine();
    }
  }
}
