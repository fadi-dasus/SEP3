package sep.via.dk.sep3JPA.service.movieService;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import sep.via.dk.sep3JPA.dao.movie.MovieDAO;
import sep.via.dk.sep3JPA.domain.movie.Movie;

@Service
public class MovieServiceImplementation implements MovieService {

	@Autowired
	private MovieDAO movieDAO;

	public MovieServiceImplementation() {

	}

	@Override
	public void AddMovie(Movie movie)  {
		movieDAO.addMovie(movie);

	}

	@Override
	public List<Movie> getListOfMovies()  {

		return movieDAO.getListOfMovies();

	}

	@Override
	public Movie getMovieById(int id)  {
		return movieDAO.getMovieById(id);
	}

	@Override
	public void deletMovie(int movieId)  {
		movieDAO.deletMovie(movieId);

	}

	@Override
	public void updateMovie(Movie movie)  {
		movieDAO.updateMovie(movie);

	}

	@Override
	public List<Movie> getMovieByTitle(String title)  {

		return movieDAO.getMovieByTitle(title);
	}

}
