package sep.via.dk.sep3JPA.service.movieService;

import java.util.List;

import sep.via.dk.sep3JPA.domain.movie.Movie;

public interface MovieService {
	public void AddMovie(Movie movie);

	public List<Movie> getListOfMovies();

	public Movie getMovieById(int id);

	public void deletMovie(int movieId);

	void updateMovie(Movie movie);

	List<Movie> getMovieByTitle(String title);

}
