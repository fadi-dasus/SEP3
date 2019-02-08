package sep.via.dk.sep3JPA;

import static org.junit.Assert.assertEquals;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.client.AutoConfigureMockRestServiceServer;
import org.springframework.boot.test.autoconfigure.web.servlet.AutoConfigureMockMvc;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.mock.web.MockHttpServletResponse;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.MvcResult;
import org.springframework.test.web.servlet.RequestBuilder;
import org.springframework.test.web.servlet.request.MockMvcRequestBuilders;

@RunWith(SpringRunner.class)
@SpringBootTest
@AutoConfigureMockMvc
@AutoConfigureMockRestServiceServer

public class Sep3JpaApplicationTests {
	   @Autowired
	    private MockMvc mockMvc;
	   
	  @Test
	    public void addMovie() throws Exception {
	        String mockMovieJson = "{\"title\":\"A Prayer Before Dawn 2018\",\"description\":\"The true story of Billy Moore, an English boxer incarcerated in Thailand's most notorious prison. Thrown into a world of drugs and violence, he finds his best chance to escape is to fight his way out in Muay Thai tournamen.\",\"director\":\"Jean-Stephane Sauvaire\",\"duration\":\"90 miutes\",\"urlTrailer\":\"https://sep3.blob.core.windows.net/mediacontainer/A%20Prayer%20Before%20Dawn%202018_trailer.mov?st=2018-12-16T22%3A02%3A04Z&se=2117-11-22T22%3A02%3A04Z&sr=c&sp=r&sig=J1BfDJ2DHaIOXGTSRGpOMG8cA8T9R%2F8teezVuMTvjiw%3D&si=tempAccess\",\"urlFullMovie\":\"https://sep3.blob.core.windows.net/mediacontainer/A%20Prayer%20Before%20Dawn%202018.mov?st=2018-12-16T22%3A02%3A04Z&se=2117-11-22T22%3A02%3A04Z&sr=c&sp=r&sig=J1BfDJ2DHaIOXGTSRGpOMG8cA8T9R%2F8teezVuMTvjiw%3D&si=tempAccess\",\"urlImage\":\"https://sep3.blob.core.windows.net/mediacontainer/A%20Prayer%20Before%20Dawn%202018.jpg?st=2018-12-19T04%3A50%3A34Z&se=2117-11-25T04%3A50%3A34Z&sr=c&sp=r&sig=rw41N9QPm6NBRHHcKJ5TqaS%2BedX3bGYqa9EPm8ANYJI%3D&si=tempAccess\",\"category\":\"Drama\"}";

	        //Create a post request with an accept header for application\json
	        RequestBuilder requestBuilder = MockMvcRequestBuilders
	                .post("/sep3/movie/")
	                .accept(MediaType.APPLICATION_JSON).content(mockMovieJson)
	                .contentType(MediaType.APPLICATION_JSON);

	        MvcResult result = mockMvc.perform(requestBuilder).andReturn();

	        MockHttpServletResponse response = result.getResponse();

	        //Assert that the return status is CREATED
	        assertEquals(HttpStatus.CREATED.value(), response.getStatus());
	        
	   
      
	    }
	  
	  
	  
}
