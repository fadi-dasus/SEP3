package sep.via.dk.sep3JPA.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import sep.via.dk.sep3JPA.domain.movie.Movie;
import sep.via.dk.sep3JPA.domain.movie.MovieFactory;
import sep.via.dk.sep3JPA.service.movieService.MovieService;

@RestController
@RequestMapping("/sep3")
public class MovieController {

	@Autowired
	private MovieService movieService;

	@PostMapping("/movie")
	public ResponseEntity<Void> addMovie(@RequestBody Movie movie) {
		Movie createdMovie = MovieFactory.create(movie.getTitle(), movie.getDirector(), movie.getDescription(),
				movie.getCategory(), movie.getDuration(), movie.getUrlTrailer(), movie.getUrlFullMovie(),
				movie.getUrlImage());

		movieService.AddMovie(createdMovie);
		HttpHeaders headers = new HttpHeaders();

		return new ResponseEntity<Void>(headers, HttpStatus.CREATED);

	}

	@GetMapping("/movies")
	public ResponseEntity<List<Movie>> getAllMovies()  {
		
		List<Movie> list = movieService.getListOfMovies();
		return new ResponseEntity<List<Movie>>(list, HttpStatus.OK);
	}

	@GetMapping("/movie/{id}")
	public ResponseEntity<Movie> getMovieById(@PathVariable("id") int id)  {

		Movie movie = movieService.getMovieById(id);
		return new ResponseEntity<Movie>(movie, HttpStatus.OK);
	}

	@DeleteMapping("/movie/{id}")
	public ResponseEntity<Void> deleteMovie(@PathVariable("id") Integer id)  {
		movieService.deletMovie(id);
		return new ResponseEntity<Void>(HttpStatus.NO_CONTENT);
	}

	@PutMapping("/movie")
	public ResponseEntity<Movie> updateMovie(@RequestBody Movie movie)  {
		movieService.updateMovie(movie);
		return new ResponseEntity<Movie>(movie, HttpStatus.OK);
	}
	
	@GetMapping("/movie/title")
	public ResponseEntity<List<Movie>> getMovieByTitle(@RequestParam("title") String title)  {

		List<Movie> list = movieService.getMovieByTitle(title);
		return new ResponseEntity<List<Movie>>(list,HttpStatus.OK);
	}

}
