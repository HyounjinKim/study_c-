using System;

namespace pr240310
{
    // 시간표 정보를 담기위한 클래스
    internal class TimeTableInfo
    {
        public string theater {  get; set; }
        public DateTime startTime {  get; set; }
        public DateTime endTime {  get; set; }
        public int movieNum {  get; set; }

        public override string ToString()
        {
            return $"상영관 = {theater} 시작시간 = {startTime} 종료시간 = {endTime} 영화번호 = {movieNum}";
        }
    }
}