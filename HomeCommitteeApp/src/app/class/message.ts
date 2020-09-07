import { Timestamp } from 'rxjs';
import { Time } from '@angular/common';

export class Message {
    id: number;
    description: string;
    day: number;
    date: Date;
    start_time: Time;
    end_time: Time;
    building_id: number;
}