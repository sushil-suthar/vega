import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';



@Injectable()
export class MakeService {

  constructor(private http: HttpClient) { }
  getMakes() {
    return this.http.get<any[]>('/api/makes')
      .pipe(
        map(res => res)
      );
  }

}
