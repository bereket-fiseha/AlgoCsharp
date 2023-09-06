using AlgorithmAndDS.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Algo.UnitTests.DS
{
    public class ArrayStackTests:IDisposable
    {
        private ArrayStack<int> nums;
        int initialCapacity;
       public ArrayStackTests() {
            initialCapacity = 5;
       nums = new ArrayStack<int>(capacity:initialCapacity);


        }


        public void Dispose()
        {
            nums = null;    }

        [Fact]
   public  void  Push_WhenCalled_AddsItemToStack() {
            //act
            var item = 1;
           nums.Push(item);

            Assert.True(nums.HasItem(item));          
        }

        [Fact]
        public void Pop_WhenCalled_ReturnsLastItemOfStack()
        {
            
            //arrange
            nums.Push(2);
            nums.Push(1);
            nums.Push(3);
            
            
            //act
           int item= nums.Pop();

            //assert
            Assert.Equal(3, item);
        }

        [Fact]
        public void Pop_WhenCalled_DecrementsLengthOfStack()
        {

            //arrange
            nums.Push(2);
            nums.Push(1);
            nums.Push(3);


            //act
            int item = nums.Pop();

            //assert
            Assert.Equal(2, nums.Count());
        }
        [Fact]
        public void Push_WhenCalled_IncrementsLengthOfStack()
        {

            //arrange and act
            nums.Push(2);
            

            //assert
            Assert.Equal(1, nums.Count());

        }
        [Fact]
        public void Push_WhenCapacityIsFull_FoldsTheCapacityOfStack()
        {

            //arrange and act
            nums.Push(2);
            nums.Push(2);
            nums.Push(2);
            nums.Push(2);
            nums.Push(2);
            nums.Push(2);

            //assert
            Assert.Equal(10, nums.TotalCapacity());

        }



    }
}
