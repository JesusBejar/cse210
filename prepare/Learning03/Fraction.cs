using System;

class Fraction  

    // this class contains all attributes and methods within this single class

{
   private int _top;
   private int _bottom;

   public Fraction () {
       _top = 1;
       _bottom = 1;
   }
   public Fraction (int wholeNum) {
       _top = wholeNum;
       _bottom = 1;
   }
   public Fraction (int top, int bottom) {
       _top = top;
       _bottom = bottom;
   }
    // Create a method called GetFractionString 
    // that returns the fraction in the form 3/4.
   public string GetFractionString () {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    // Create a method called GetDecimalValue that returns a double that is the result of 
    // dividing the top number by the bottom number, such as 0.75.
    public double GetDecimalValue () {
        return (double)_top / (double)_bottom;
    }

}