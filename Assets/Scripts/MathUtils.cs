
using System;
/**
 * @author KiteJencien
 * @since 9/29/2020
 */
public class MathUtils {

    //a method to generate random floats for the game system to use
    public static float GetRandomFloat(float floor, float roof) {

        Random rand = new Random();
        String str = rand.NextDouble().ToString();
        
        float ret =  float.Parse(str.Substring(0, 6));
        return floor + ret * roof;
    }
}
