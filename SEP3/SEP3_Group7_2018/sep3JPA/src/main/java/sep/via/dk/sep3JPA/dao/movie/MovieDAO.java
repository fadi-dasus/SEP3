package sep.via.dk.sep3JPA.dao.movie;

import java.util.List;

import sep.via.dk.sep3JPA.domain.movie.Movie;

public interface MovieDAO {
	void addMovie(Movie movie);

	List<Movie> getListOfMovies();

	Movie getMovieById(int id);

	void deletMovie(int movieId);

	void updateMovie(Movie movie);

	public List<Movie> getMovieByTitle(String titleS);
}
