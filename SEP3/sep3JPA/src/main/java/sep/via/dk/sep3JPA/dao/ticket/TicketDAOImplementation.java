package sep.via.dk.sep3JPA.dao.ticket;

import java.time.LocalDate;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import sep.via.dk.sep3JPA.domain.Ticket;

@Transactional
@Repository
public class TicketDAOImplementation implements TicketDAO {

	@PersistenceContext
	@Autowired
	public EntityManager entityManager;

	@Override
	public void addTicket(Ticket ticket)  {
		ticket.setIssuingDate(LocalDate.now());
		entityManager.persist(ticket);
	}

}
