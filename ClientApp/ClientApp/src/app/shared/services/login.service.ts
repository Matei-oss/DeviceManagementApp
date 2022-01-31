import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http: HttpClient) { 
    

  }

  public login$(userName: string, password: string): Observable<string>{
    

      // Initialize Params Objectlet 

    let params = new HttpParams();
      // Begin assigning parameters
    params = params.append('emailAddress', userName);
    params = params.append('password', password);
  
      // Make the API call using the new parameters.return this._HttpClient.get(`${API_URL}/api/v1/data/logs`, { params: params })

    return this.http.get(
      'https://localhost:7288/api/Authorization',
      {
        params,
        responseType: 'text'
      }
    );
  }
}

