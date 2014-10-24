import static org.junit.Assert.*;

import org.junit.Test;


public class GreeterTest {

	@Test
	public void CanGreet(){
		Greeter greeter=new Greeter();
		String greet=greeter.greet();
		assertEquals("Hello World",greet);
	}
}
