package main

import (
	"fmt"
	"time"
)

func main() {
	var n uint
	fmt.Print("Введіть натуральне число: ")
	// fmt.Scan(&n)
	n = 20000
	result := "1"
	startTime := time.Now()

	for i := uint(2); i <= n; i++ {
		result += fmt.Sprintf(" %d", i)
	}
	fmt.Println(result)

	endTime := time.Now()
	elapsedTime := endTime.Sub(startTime).Milliseconds()
	fmt.Printf("Execution time: %dms\n", elapsedTime)

}
