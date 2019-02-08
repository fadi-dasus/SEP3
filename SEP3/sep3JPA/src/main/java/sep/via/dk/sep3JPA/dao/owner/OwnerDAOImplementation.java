package sep.via.dk.sep3JPA.dao.owner;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import sep.via.dk.sep3JPA.domain.Owner;

@Transactional
@Repository
public class OwnerDAOImplementation implements OwnerDAO {

	@PersistenceContext
	@Autowired
	public EntityManager entityManager;

	@Override
	public boolean ownerExist(String username) {
		String jpql = "from Owner as a WHERE a.username = ?0 ";
		int count = entityManager.createQuery(jpql).setParameter(0, username).getResultList().size();
		return count > 0;

	}

	@Override
	public void addOwner(Owner owner) {
		entityManager.persist(owner);

	}

	@Override
	public Owner getOwnerById(int id) {
		return entityManager.find(Owner.class, id);
	}

}
