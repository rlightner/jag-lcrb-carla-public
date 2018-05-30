import { DynamicsAccount } from './dynamics-account.model';

export class Shareholder {
  shareholderType: string;
  //email: string;
  //numberOfNonVotingShares: number;
  //numberOfVotingShares: number;
  //dateIssued: Date;

  // string form of the guid.
  id: string;
  name: string;
  isindividual: boolean;
  sameasapplyingperson: boolean;
  legalentitytype: string;
  otherlegalentitytype: string;
  firstname: string;
  middlename: string;
  lastname: string;
  position: string;
  dateofbirth: Date;
  interestpercentage: number;
  commonvotingshares: number;
  preferredvotingshares: number;
  commonnonvotingshares: number;
  preferrednonvotingshares: number;
  account: DynamicsAccount;
  relatedentities: any[];
  //List < AdoxioLegalEntity > relatedentities ;                
}