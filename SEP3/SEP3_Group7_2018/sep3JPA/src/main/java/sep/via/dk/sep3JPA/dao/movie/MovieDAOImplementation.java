package sep.via.dk.sep3JPA.dao.movie;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import sep.via.dk.sep3JPA.domain.movie.Movie;

@Transactional
@Repository
public class MovieDAOImplementation implements MovieDAO {

	@PersistenceContext
	@Autowired
	public EntityManager entityManager;

	@Override
	public void addMovie(Movie movie)  {
		entityManager.persist(movie);

	}

	@SuppressWarnings("unchecked")
	@Override
	public List<Movie> getListOfMovies() {
		String query = "select m from Movie m order by m.title";

		return (List<Movie>) entityManager.createQuery(query).getResultList();
	}

	@Override
	public Movie getMovieById(int id)  {
		return entityManager.find(Movie.class, id);

	}

	@Override
	public void deletMovie(int movieId)  {
		entityManager.remove(getMovieById(movieId));

	}

	@Override
	public void updateMovie(Movie movie) {
		Movie selectedMovie = getMovieById(movie.getId());
		selectedMovie.setTitle(movie.getTitle());
		selectedMovie.setDirector(movie.getDirector());
		selectedMovie.setDescription(movie.getDescription());
		selectedMovie.setCategory(movie.getCategory());
		selectedMovie.setDuration(movie.getDuration());
		selectedMovie.setUrlFullMovie(movie.getUrlFullMovie());
		selectedMovie.setUrlImage(movie.getUrlImage());
		selectedMovie.setUrlTrailer(movie.getUrlTrailer());
		entityManager.flush();
	}

	@SuppressWarnings("unchecked")
	@Override
	public List<Movie> getMovieByTitle(String title) {
		String jpql = "select * from Movie as a WHERE a.title = ?0 ";
		return (List<Movie>) entityManager.createNativeQuery(jpql).setParameter(0, title).getResultList();

	}

}
