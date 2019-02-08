package sep.via.dk.sep3JPA.service.ownerService;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import sep.via.dk.sep3JPA.dao.owner.OwnerDAO;
import sep.via.dk.sep3JPA.domain.Owner;

@Service
public class OwnerServiceImplementation implements OwnerService {

	@Autowired
	private OwnerDAO ownerDAO;

	@Override
	public boolean addOwner(Owner owner) {
		if (ownerDAO.ownerExist(owner.getUsername())) {
			return false;
		} else {
			ownerDAO.addOwner(owner);
			return true;
		}

	}

	@Override
	public Owner getOwnerById(int id)  {
		return ownerDAO.getOwnerById(id);
	}

}
