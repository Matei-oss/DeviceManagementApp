import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DeviceService {
  constructor(private http: HttpClient) { }

  public getDevices$(): Observable<any>{
  
    return this.http.get(
      'https://localhost:7288/api/Devices')
  }

  public addDevice$(device: any): Observable<any>{
      return this.http.post(
        'https://localhost:7288/api/Devices',
        device
      )
  }
}
