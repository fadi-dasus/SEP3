package sep.via.dk.sep3JPA.dao.owner;

import sep.via.dk.sep3JPA.domain.Owner;

public interface OwnerDAO{
	boolean ownerExist(String username);

	void addOwner(Owner owner);

	Owner getOwnerById(int id);

}
