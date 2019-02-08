package sep.via.dk.sep3JPA.dao.message;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import sep.via.dk.sep3JPA.domain.Message;

@Transactional
@Repository
public class MessageImplementation implements MessageDAO {
	@PersistenceContext
	@Autowired
	public EntityManager entityManager;

	

	@Override
	public void addMessage(Message feedBack) {
		entityManager.persist(feedBack);
		
	}

	@Override
	public List<Message> getAllMessages() {
		String query = "select m from Message m order by m.name";

		return (List<Message>) entityManager.createQuery(query).getResultList();
	}

}
