package main

import (
	"fmt"
	"strings"
	"time"
)

func main() {
	var n uint
	fmt.Print("Введіть натуральне число: ")
	fmt.Scan(&n)
	// n = 400

	var builder strings.Builder
	builder.WriteString("1")

	startTime := time.Now()
	for i := uint(2); i <= n; i++ {
		builder.WriteString(fmt.Sprintf(" %d", i))
	}
	result := builder.String()
	fmt.Println(result)

	endTime := time.Now()
	elapsedTime := endTime.Sub(startTime).Milliseconds()
	fmt.Printf("Execution time: %dms\n", elapsedTime)
}
