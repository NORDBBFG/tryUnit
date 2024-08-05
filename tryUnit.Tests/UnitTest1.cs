namespace tryUnit.Tests
{
    public class Tests
    {

        [Test]
        public void Verify_CountMaxUniqueConsecutiveChars_return_corect_value_whith_valid_data()
        {
            //Arrange 
            int actual = 0;

            //Act
            try
            {
                actual = Class1.CountMaxUniqueConsecutiveChars("asdfadd");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Assert
            Assert.That(actual, Is.EqualTo(6));
        }

        [Test]
        public void Verify_CountMaxIdenticalLetters_return_corect_value_whith_valid_data()
        {
            //Arrange 
            int actual = 0;

            //Act
            try
            {
                actual = Class1.CountMaxIdenticalLetters("aasdnnnf55555");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Assert
            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void Verify_CountMaxIdenticalDigit_return_corect_value_whith_valid_data()
        {
            //Arrange 
            int actual = 0;

            //Act
            try
            {
                actual = Class1.CountMaxIdenticalDigit("gdhtttt55555");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Assert
            Assert.That(actual, Is.EqualTo(5));
        }
    }
}