/*
 * C# supports ?. operator to check null values. 
 * This class demos the use of ?. operator for null checking
 * ?. is evaluated as "if null then null, if not then dot"
 * That means if left side or the operator is null then the expression is null and the expression will not be evaluated further.
 * If not then . will be used and the expression will be evaluated further. * 
 * 
 * NullableTypeDemo class is referenced for this demo.
 */

namespace CSBasic
{
    class NullCheckingDemo
    {
        public double? CheckForNull()
        {            
            var nullDemoObj = new NullableTypeDemo();

            // The below call will return Null. Sicne nullableCost was never initialized. 
            return nullDemoObj?.nullableCost;
        }

        public double? GetCostValue()
        {            
            var nullDemoObj = new NullableTypeDemo();
            nullDemoObj.nullableCost = 10.0;

            // The below call will return 10.0 since nullableCost was initialized to 10.0
            return nullDemoObj?.nullableCost;
        }
    }
}
