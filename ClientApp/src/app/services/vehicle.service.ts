import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';



@Injectable()
export class VehicleService {

  constructor(private http: HttpClient) { }
  getMakes() {
    return this.http.get<any[]>('/api/makes')
      .pipe(
        map(res => res)
      );
  }
  getFeatures() {
    return this.http.get<any[]>('/api/features')
      .pipe(
        map(res => res)
      );
  }

}
