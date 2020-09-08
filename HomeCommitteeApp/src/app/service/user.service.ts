import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../classes/user';
@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpClient) { 

    
   }

  // getUserById(id):Observable<any>{
  //   return this.http.get('http://localhost:65337/api/User/{{id}}');
  // }
  getUserByPasssword(name,password):Observable<any>{
    return this.http.get('http://localhost:65337/api/User/{{name,password }}')
  }
}
