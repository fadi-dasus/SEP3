package sep.via.dk.sep3JPA.dao.login;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import sep.via.dk.sep3JPA.dao.customer.CustomerDAO;
import sep.via.dk.sep3JPA.domain.Customer;

@Transactional
@Repository

public class LoginDAOImplementation implements LoginDao {
	@PersistenceContext
	@Autowired
	public EntityManager entityManager;
	@Autowired
	private CustomerDAO customerDao;

	@Override
	public boolean customerAuthentication(String username, String password) {

		String jpql = "from Customer as a WHERE a.username = ?0  and a.password = ?1";
		int count = entityManager.createQuery(jpql).setParameter(0, username).setParameter(1, password).getResultList()
				.size();

		return count > 0;

	}

	@Override
	public boolean ownerAuthentication(String username, String password) {

		String jpql = "from Owner as a WHERE a.username = ?0  and a.password = ?1";
		int count = entityManager.createQuery(jpql).setParameter(0, username).setParameter(1, password).getResultList()
				.size();
		return count > 0;
	}

	@Override
	public boolean AuthenticateSubscription(String username) {
		Customer updatedCustomer = customerDao.getCustomerByUsername(username);

		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy MM dd");
		String selectedDate = updatedCustomer.getExpiryDate();
		if (selectedDate != null) {
			LocalDate parsedDate = LocalDate.parse(selectedDate, formatter);

			LocalDate today = LocalDate.now();

			if (today.isBefore(parsedDate)) {

				return true;
			}

			else if (today.isAfter(parsedDate)) {

				return false;
			}
		}
		return false;
	}
}
